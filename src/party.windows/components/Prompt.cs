namespace party.windows.components
{
    using System.Windows.Forms;
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string defaultValue)
        {
            Form prompt = new()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new() { Left = 50, Top = 50, Width = 400, Text = defaultValue };
            Button confirmation = new() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : defaultValue;
        }
    }
}
