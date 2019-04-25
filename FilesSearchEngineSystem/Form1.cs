using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesSearchEngineSystem
{
   

    public partial class mainForm : Form
    {

        AddNewFileForm addNewFileForm;
        FilesInformationForm filesInformationForm;
        AddNewCategoryForm addNewCategoryForm;
        FileCategoriesForm fileCategoriesForm;
        CategoryKeywordsForm categoryKeywordsForm;
        CategoryInformationForm categoryInformationForm;
        FileContentForm fileContentForm;

        public mainForm()
        {
            InitializeComponent();
        }

        private void addFileBtn_Click(object sender, EventArgs e)
        {
            addNewFileForm = new AddNewFileForm();
            removePanelForms();
            displayPanelForm(addNewFileForm);
        }

        private void displayFilesInfoBtn_Click(object sender, EventArgs e)
        {
            filesInformationForm = new FilesInformationForm();
            removePanelForms();
            displayPanelForm(filesInformationForm);
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            addNewCategoryForm = new AddNewCategoryForm();
            removePanelForms();
            displayPanelForm(addNewCategoryForm);
        }

        private void displayFileCategoriesBtn_Click(object sender, EventArgs e)
        {
            fileCategoriesForm = new FileCategoriesForm();
            removePanelForms();
            displayPanelForm(fileCategoriesForm);
        }

        private void displayCategoryKeywordBtn_Click(object sender, EventArgs e)
        {
            categoryKeywordsForm = new CategoryKeywordsForm();
            removePanelForms();
            displayPanelForm(categoryKeywordsForm);
        }

        private void categoryInformationBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void fileContentBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void removePanelForms()
        {
            pages.Controls.Remove(addNewFileForm);
            pages.Controls.Remove(filesInformationForm);
            pages.Controls.Remove(addNewCategoryForm);
            pages.Controls.Remove(fileCategoriesForm);
            pages.Controls.Remove(categoryKeywordsForm);
            pages.Controls.Remove(categoryInformationForm);
            pages.Controls.Remove(fileContentForm);
        }

        private void displayPanelForm(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            pages.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void fileContentBtn_Click_1(object sender, EventArgs e)
        {
            fileContentForm = new FileContentForm();
            removePanelForms();
            displayPanelForm(fileContentForm);
        }

        private void categoryInformationBtn_Click_1(object sender, EventArgs e)
        {
            categoryInformationForm = new CategoryInformationForm();
            removePanelForms();
            displayPanelForm(categoryInformationForm);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
