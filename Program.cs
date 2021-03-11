using System;
using System.IO;
using IronPdf;

namespace Eras.Public.IronPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = @"
                <style>
                    .container {
                        display: flex;
                        height: 100px;
                        background-color: red;
                        justify-content: space-around;
                        align-items: center;
                    }

                    .cell {
                        height: 50px;
                        width: 50px;
                        background-color: blue;
                    }
                </style>
                <div class='container'>
                    <div class='cell'></div>
                    <div class='cell'></div>
                    <div class='cell'></div>
                </div>";

            string directory = Path.GetTempPath();
            string file = $"{Guid.NewGuid()}.pdf";
            string path = Path.Combine(directory, file);

            HtmlToPdf renderer = new HtmlToPdf();
            renderer.RenderHtmlAsPdf(html).SaveAs(path);

            Console.WriteLine(path);
        }
    }
}
