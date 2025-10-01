using SpreadCheetah;
using System.IO;
using ExcelDataReader;
using System.Data;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string excelSpreadsheet = "C:\\Users\\rodf\\OneDrive\\Documents\\Sample Excel Spreadsheet.xlsx";

// Register encoding provider needed by ExcelDataReader
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

try
{
    using var stream = File.Open(excelSpreadsheet, FileMode.Open, FileAccess.Read);
    using var reader = ExcelReaderFactory.CreateReader(stream);

    // Use the AsDataSet extension method to get all sheets
    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
    {
        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
        {
            UseHeaderRow = true // Use the first row as column names
        }
    });

    // Access the first sheet
    var table = result.Tables[0];

    Console.WriteLine($"Reading sheet: {table.TableName}");
    Console.WriteLine($"Found {table.Rows.Count} rows and {table.Columns.Count} columns");
    Console.WriteLine("Sheet data:");

    // Print the column headers
    for (int col = 0; col < table.Columns.Count; col++)
    {
        Console.Write($"{table.Columns[col].ColumnName}\t");
    }
    Console.WriteLine();

    // Print each row of data
    for (int row = 0; row < table.Rows.Count; row++)
    {
        for (int col = 0; col < table.Columns.Count; col++)
        {
            Console.Write($"{table.Rows[row][col]}\t");
        }
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error reading Excel file: {ex.Message}");
}
