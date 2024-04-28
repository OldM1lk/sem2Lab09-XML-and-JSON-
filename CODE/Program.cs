using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NLog;

namespace XMLandJSON
{
    interface IView
    {
        string FirstDirectory();
        string SecondDirectory();

        void Synchronize(List<string> messages);

        event EventHandler<EventArgs> SynchronizeDirectories;
    }

    class Model
    {
        public List<string> SynchronizingDirectories(string firstDirectory, string secondDirectory)
        {
            DirectoryInfo sourceDirectory = new DirectoryInfo(firstDirectory);
            DirectoryInfo destinationDirectory = new DirectoryInfo(secondDirectory);

            List<string> synchronizationResult;

            synchronizationResult = InternalDirectorySynchronization(sourceDirectory, destinationDirectory);

            return synchronizationResult;
        }

        private List<string> InternalDirectorySynchronization(DirectoryInfo firstDirectory, DirectoryInfo secondDirectory)
        {
            List<string> changesList = new List<string>();

            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Info($"Синхронизация директории {secondDirectory} до соответствия с директорией {firstDirectory}");

            foreach (FileInfo file in firstDirectory.GetFiles())
            {
                FileInfo fileInSecondDirectory = new FileInfo(Path.Combine(secondDirectory.FullName, file.Name));

                if (!fileInSecondDirectory.Exists)
                {
                    File.Copy(file.FullName, fileInSecondDirectory.FullName, true);
                    changesList.Add($"Файл {file.Name} создан");
                    logger.Info($"Результат синхронизации: файл {file.Name} создан в директории {fileInSecondDirectory}");
                }
                else if (fileInSecondDirectory.LastWriteTime != file.LastWriteTime)
                {
                    File.Copy(file.FullName, fileInSecondDirectory.FullName, true);
                    changesList.Add($"Файл {file.Name} изменен");
                    logger.Info($"Результат синхронизации: файл {file.Name} изменен в директории {fileInSecondDirectory}");
                }
            }

            foreach (FileInfo file in secondDirectory.GetFiles())
            {
                FileInfo fileInFirstDirectory = new FileInfo(Path.Combine(firstDirectory.FullName, file.Name));

                if (!fileInFirstDirectory.Exists)
                {
                    file.Delete();
                    changesList.Add($"Файл {file.Name} удален");
                    logger.Info($"Результат синхронизации: файл {file.Name} удален из директории {fileInFirstDirectory}");
                }
            }

            if (changesList.Count == 0)
            {
                changesList.Add("Директории уже синхронизированы");
                logger.Info($"Результат синхронизации: директории не нуждаются в синхронизации");
            }

            return changesList;
        }
    }

    class Presenter
    {
        private IView view;
        private Model model;
        public Presenter(IView newView)
        {
            view = newView;
            model = new Model();

            view.SynchronizeDirectories += new EventHandler<EventArgs>(Synchronize);
        }

        private void Synchronize(object sender, EventArgs newEvent)
        {
            List<string> resultOfSynchronization = model.SynchronizingDirectories(view.FirstDirectory(), view.SecondDirectory());
            view.Synchronize(resultOfSynchronization);
        }
    }

    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
        }
    }
}