string appPath = @"..\..\..\";
string myFolder = appPath + "Files";
string txtPath = myFolder + @"\names.txt";

if (!Directory.Exists(myFolder))
{
    Directory.CreateDirectory(myFolder);
}
if (!File.Exists(txtPath))
{
    File.Create(txtPath).Close();
}

List<string> existingNames = File.ReadAllLines(txtPath)
    .Select(n => n.Trim())
    .Where(n => !string.IsNullOrWhiteSpace(n))
    .ToList();

if (existingNames.Count == 0)
{
    Console.WriteLine("The file is empty.");
}
else
{
    Console.WriteLine("Current names in the file:");
    foreach (string name in existingNames)
    {
        Console.WriteLine(name);
    }
}

Console.WriteLine("Enter names (separated by commas):");
string? input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input))
{
    List<string> names = input.Split(',', StringSplitOptions.RemoveEmptyEntries)
        .Select(n => n.Trim())
        .Where(n => !string.IsNullOrWhiteSpace(n))
        .ToList();

    using (StreamWriter writer = new StreamWriter(txtPath, append: true))
    {
        foreach (string name in names)
        {
            writer.WriteLine(name);
        }
    }
    Console.WriteLine("Names have been saved to the file.");
}
else
{
    Console.WriteLine("No names entered.");
}

List<string> allNames = File.ReadAllLines(txtPath)
    .Select(n => n.Trim())
    .Where(n => !string.IsNullOrWhiteSpace(n))
    .ToList();

for (char letter = 'A'; letter <= 'Z'; letter++)
{
    var filtered = allNames
        .Where(name => name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
        .Distinct(StringComparer.OrdinalIgnoreCase)
        .ToList();

    if (filtered.Count > 0)
    {
        string filteredFile = Path.Combine(myFolder, $"namesStartingWith_{letter}.txt");

        if (File.Exists(filteredFile))
        {
            var existing = File.ReadAllLines(filteredFile)
                .Select(n => n.Trim())
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            var newNames = filtered.Where(n => !existing.Contains(n)).ToList();

            if (newNames.Count > 0)
            {
                File.AppendAllLines(filteredFile, newNames);
            }
        }
        else
        {
            File.WriteAllLines(filteredFile, filtered);
        }
    }
}
