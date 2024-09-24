class Programm
{
    static void Main(string[] argv)
    {
        Console.WriteLine("Введите лицензионный ключ доступа (pro или exp),если он есть. ");
        string key = Console.ReadLine();

        DocumentWorker worker;

        if (key == "pro")
        {
            worker = new ProDocumentWorker();
        }
        else if (key == "exp")
        {
            worker = new ExpertDocumentWorker();
        }
        else
        {
            worker = new DocumentWorker();
        }

        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}


class DocumentWorker
{

    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ Открыт");
    }

    public virtual void EditDocument() 
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument() {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}