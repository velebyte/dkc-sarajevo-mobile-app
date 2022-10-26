namespace dkc_sarajevo_maui;

public partial class NotePage : ContentPage
{
    string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

    public NotePage()
	{
		InitializeComponent();

		if (File.Exists(_fileName))
		{
			TextEditor.Text = File.ReadAllText(_fileName);
		}
	}

    private async void OnSaveButtonClicked(object sender, EventArgs e)
	{
        await File.WriteAllTextAsync(_fileName, TextEditor.Text);
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        // Delete the file.
        if (File.Exists(_fileName))
            File.Delete(_fileName);

        TextEditor.Text = string.Empty;
    }
}