namespace Exercise2_FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordFactory();
            wordFactory.CreateDocument().Open();

            DocumentFactory pdfFactory = new PdfFactory();
            pdfFactory.CreateDocument().Open();

            DocumentFactory excelFactory = new ExcelFactory();
            excelFactory.CreateDocument().Open();
        }
    }
}