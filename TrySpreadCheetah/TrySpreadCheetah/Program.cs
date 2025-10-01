using SpreadCheetah;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string excelSpreadsheet = "C:\\Users\\rodf\\OneDrive\\Documents\\Sample Excel Spreadsheet.xlsx";

// To read an Excel file, you would need to use a library like ExcelDataReader instead:
// Here's how you would do it with ExcelDataReader:

/*
// Don't forget to register encoding provider
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

using var stream = File.Open(excelSpreadsheet, FileMode.Open, FileAccess.Read);
using var reader = ExcelReaderFactory.CreateReader(stream);

// DataSet approach
var result = reader.AsDataSet(new ExcelDataSetConfiguration()
{
    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
});

// Print out the data
var table = result.Tables[0]; // First sheet
for (int row = 0; row < table.Rows.Count; row++)
{
    for (int col = 0; col < table.Columns.Count; col++)
    {
        Console.Write($"{table.Rows[row][col]}\t");
    }
    Console.WriteLine();
}
*/
