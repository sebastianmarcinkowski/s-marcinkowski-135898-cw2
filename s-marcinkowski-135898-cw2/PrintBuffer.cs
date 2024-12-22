namespace s_marcinkowski_135898_cw2;

public class PrintBuffer
{
    private static readonly PrintBuffer _instance = new PrintBuffer();
    private Queue<string> _printQueue;
    
    private PrintBuffer()
    {
        _printQueue = new Queue<string>();
    }
    
    public static PrintBuffer Instance
    {
        get { return _instance; }
    }
    
    public void AddPrintJob(string document)
    {
        _printQueue.Enqueue(document);
        Console.WriteLine($"Dodano zadanie do bufora: {document}");
    }
    
    public bool ProcessNextJob()
    {
        if (_printQueue.Count > 0)
        {
            string document = _printQueue.Dequeue();
            Console.WriteLine($"Przetwarzanie zadania: {document}");
            return true;
        }
        else
        {
            Console.WriteLine("Brak zadań w buforze");
            return false;
        }
    }
    
    public IEnumerable<string> GetPendingJobs()
    {
        return _printQueue.ToArray();
    }
}