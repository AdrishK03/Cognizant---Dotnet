namespace Exercise2_FactoryMethodPattern
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Word Document Opened");
        }
    }
}