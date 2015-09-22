namespace BackgroundWorkingWithMVC.Application.BackgroudWorkers
{
    public interface IWorker<T>
    {
        void Initialize();

        void StartOperation();

        void CompleteOperation();
        
        void AddLog(string message = "", int? rowCount = 0);
    }
}