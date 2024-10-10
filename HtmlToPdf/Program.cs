using Aspose.Pdf;

class Program
{
    static void Main(string[] args)
    {
        // Crate Option
        HtmlLoadOptions htmloptions = new HtmlLoadOptions();
        // Find And Load Html Document 
        Document doc = new Document(@"C:\Users\Amin\Desktop\test.html", htmloptions);
        // Save Converted pdf document
        doc.Save("example.pdf");

        //Use Aspose NuGet Package 
        //Version (24.9.0)
    }

    
}
