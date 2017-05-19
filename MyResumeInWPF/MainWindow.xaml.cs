using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyResume
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //http://www.wpf-tutorial.com/listview-control/listview-data-binding-item-template/

            Resume v_myResume = new Resume();
            m_civilList.ItemsSource = v_myResume.Civil;
            m_hobbiesList.ItemsSource = v_myResume.Hobbies;

            //Skills : Telerik radar ?
            m_skillsList.ItemsSource = v_myResume.Skills;

            //grouper par Catégorie : http://www.wpf-tutorial.com/listview-control/listview-grouping/
            CollectionView view = (CollectionView) CollectionViewSource.GetDefaultView(m_skillsList.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Catégorie");
            view.GroupDescriptions.Add(groupDescription);


            m_languagesList.ItemsSource = v_myResume.Languages;
        }
       
    }
}
