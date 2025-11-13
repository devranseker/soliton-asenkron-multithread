using System.Diagnostics.Metrics;
using System.Reflection;

namespace TaskFormApp
{
    public partial class Form1 : Form
    {

        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void B_GUI_TaskAppAsekronRead_Click(object sender, EventArgs e)
        {
            string data = ReadFile();   
            B_GUI_richTextBoxDosyaShow.Text = data;  

        }

        private void B_GUI_SayacCounter_Click(object sender, EventArgs e)
        {
            GUI_TextBoxCounter.Text = counter++.ToString();
        }

        //private string ReadFile()
        //{
        //    string data = string.Empty;

        //    //StreamReader sr = new StreamReader();  // Aþaðýdaki gibi kullanmak daha doðru olur
        //    using (StreamReader sr = new StreamReader("TaskAppAsenkron.txt"))
        //    {
        //        Thread.Sleep(5000); // 5 saniye bekletme iþlemi (Simülasyon amaçlý)
        //        data = sr.ReadToEnd();

        //    }
        //    return data;    
        //}

        // þimdi asenkron versiyonunu yapalým

        // senkronda private void  , Asenkronda private async Task<dataType>  
        // senkronda string  , Asenkronda async Task<string>


        private async Task<> ReadFileAsync()
        {

            string data = string.Empty;
            using (StreamReader s = new StreamReader("TaskAppAsenkron.txt")) ;
            {
                data = s.ReadToEndAsync();

            }


        }
     




    }
}
