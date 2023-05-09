using System.IO;



namespace RotinaDeSubstituição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string origem = @"C:\Users\03461471232\Documents\Arquivosparaler";
            string destino = @"D:\Nova pasta";

            Directory.CreateDirectory(destino);

            foreach (string dirPath in Directory.GetDirectories(origem, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.(origem, destino));
            
            toolStripStatusLabel1.Text = origem;
            statusStrip1.Refresh();
            Thread.Sleep(1000);

            foreach (string filePath in Directory.GetFiles(origem, ".", SearchOption.AllDirectories))
            File.Copy(filePath, filePath.Replace(origem, destino), true);

           
            toolStripStatusLabel1.Text = " Pronto " +  origem.Count()  + " Arquivos " + "copiados! ";
            
            MessageBox.Show("Arquivos Copiados com Sucesso!!");
        }
    }
}
