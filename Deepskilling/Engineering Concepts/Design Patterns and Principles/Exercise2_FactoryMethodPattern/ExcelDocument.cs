namespace Exercise2_FactoryMethodPattern
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Excel Document Opened");
        }
    }
}