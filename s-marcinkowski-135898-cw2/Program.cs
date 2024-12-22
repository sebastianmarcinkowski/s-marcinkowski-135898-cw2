using s_marcinkowski_135898_cw2;

// var printBuffer = new PrintBuffer(); -> Konstruktor prywatny, nie można utworzyć nowego obiektu

var printBuffer = PrintBuffer.Instance; // Pobieramy instancję bufora wydruku

printBuffer.AddPrintJob("Document 1");

printBuffer = PrintBuffer.Instance; // Sprawdzam czy instacja jest taka sama

printBuffer.AddPrintJob("Document 2");
printBuffer.AddPrintJob("Document 3");

Console.WriteLine("Lista zadań w buforze wydruku:");

foreach (var job in printBuffer.GetPendingJobs())
{
    Console.WriteLine(job);
}

Console.WriteLine("Rozpoczęto procesowanie zadań w buforze wydruku");

printBuffer = PrintBuffer.Instance; // Sprawdzam czy instacja jest taka sama

while (printBuffer.ProcessNextJob())
{
}

Console.WriteLine("Zakończono procesowanie zadań w buforze wydruku");

// Program zwrócił wynik:
// Dodano zadanie do bufora: Document 1
// Dodano zadanie do bufora: Document 2
// Dodano zadanie do bufora: Document 3
// Lista zadań w buforze wydruku:
// Document 1
// Document 2
// Document 3
// Rozpoczęto procesowanie zadań w buforze wydruku
// Przetwarzanie zadania: Document 1
// Przetwarzanie zadania: Document 2
// Przetwarzanie zadania: Document 3
// Brak zadań w buforze
// Zakończono procesowanie zadań w buforze wydruku
// Singletion jest zaimplenetowany poprawnie