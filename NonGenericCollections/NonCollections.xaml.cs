using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections;
using System.Collections.Specialized;
using System.Data.OracleClient;
using System.Threading.Tasks.Dataflow;

namespace Practiceforunstd2
{
    /// <summary>
    /// Interaction logic for Collections.xaml
    /// </summary>
    public partial class Collections : Window
    {
        public Collections()
        {
            InitializeComponent();
        }

        private void ArrayList_Click(object sender, RoutedEventArgs e)
        {   //ArrayList
            ArrayList array = new ArrayList();
            array.Add("D Ragavan");
            MessageBox.Show(array.ToString());

            string[] name = { "Senan", "Kanishka", "Nivetha" };
            int[] nums = { 1, 2, 3, 4, 5 };
            ArrayList oarray = new ArrayList() { "Ishu", "Kani", "Nila" };
            oarray.AddRange(name);
            oarray.Insert(0, "Vasanth");
            oarray.InsertRange(1, nums);
            oarray.Remove(nums);
            oarray.RemoveAt(0);
            int count = oarray.Count;
            for (int i = 0; i < count; i++)
            {
                MessageBox.Show(oarray[i].ToString());
            }
            foreach (var items in oarray)
            {
                MessageBox.Show(items.ToString());
            }
        }

        private void Hashtable_Click(object sender, RoutedEventArgs e)
        {  //Hashtable
            Hashtable ohash = new Hashtable();
            ohash.Add("Name", "Vasanthasenan");
            ohash.Add("Age", 21);
            foreach (var items in ohash.Keys)
                MessageBox.Show(items.ToString());
            foreach (var item in ohash.Values)
                MessageBox.Show(item.ToString());
            foreach (var items in ohash)
                MessageBox.Show(items.ToString());
        }

        private void Stack_Click(object sender, RoutedEventArgs e)
        {   //Stack LIFO
            Stack ostack = new Stack();
            ostack.Push("Vasanthasenan");
            ostack.Push("Kanisha");
            ostack.Push(4);
            string name = ostack.Peek().ToString();
            MessageBox.Show(name);
            ostack.Pop();
            string names = ostack.Peek().ToString();
            MessageBox.Show(names);
        }

        private void Queue_Click(object sender, RoutedEventArgs e)
        {   //Queue FIFO
            Queue oqueue = new Queue();
            oqueue.Enqueue("ishu");
            oqueue.Enqueue("kanishka");
            oqueue.Enqueue("vasanth");
            string name1 = oqueue.Peek().ToString();
            MessageBox.Show(name1);
            oqueue.Dequeue();
            string names1 = oqueue.Peek().ToString();
            MessageBox.Show(names1);

        }

        private void SortedList_Click(object sender, RoutedEventArgs e)
        {   //SortrdList
            SortedList olist = new SortedList();
            olist.Add("Z", "26");
            olist.Add("X", "24");
            olist.Add("A", "1");
            foreach (var items in olist)
            {
                MessageBox.Show(items.ToString());
            }
        }

        private void BitArray_Click(object sender, RoutedEventArgs e)
        {   //BitArray
            BitArray obit = new BitArray(3);
            obit[0] = true;
            obit[1] = false;
            obit[2] = true;
        }

        private void ListDictionary_Click(object sender, RoutedEventArgs e)
        {   //ListDictionary - Similar to Hashtable but Efficient for small collections.

            ListDictionary lisdic = new ListDictionary();
            lisdic.Add("Name", "Vasanthasenan");
            lisdic.Add("Age", 21);
            foreach (var items in lisdic.Keys)
                MessageBox.Show(items.ToString());
            foreach (var item in lisdic.Values)
                MessageBox.Show(item.ToString());
            foreach (DictionaryEntry items in lisdic)
                MessageBox.Show(items.ToString());
        }

        private void HybridDictionary_Click(object sender, RoutedEventArgs e)
        {  //HybridDictionary - perform like Hashtable when collections are more and
           //perform like ListDictionary when collections are small
            HybridDictionary ohyd = new HybridDictionary();
        }

        private void NamevalueCollection_Click(object sender, RoutedEventArgs e)
        {   //NameValueCollection - Similar to Hashtable but same named key have one or more values
            NameValueCollection oname = new NameValueCollection();
            oname.Add("Name", "Vasanthasenan");
            oname.Add("Name", "Thiru");
            oname.Add("Age", "21");
            oname.Add("Age", "24");

        }

        private void StringCollection_Click(object sender, RoutedEventArgs e)
        {   //Similar to Array list But Allows string only.
            StringCollection ostring = new StringCollection() { "1", "Kani" };
            ostring.Add("vasanth");
            ostring.Add("Ishu");
        }

        private void StringDictionary_Click(object sender, RoutedEventArgs e)
        {   //similar to hashtable but allows String Values only
            StringDictionary osdic = new StringDictionary();
            osdic.Add("Name", "Thiru");
            osdic.Add("Age", "21");
        }

        private void GenericCollections_Click(object sender, RoutedEventArgs e)
        {
            //1.List Basic
            List<int> ints = new List<int>()
          {
              10,20,30,40

          };
            foreach (int i in ints)
            {
                MessageBox.Show(i.ToString());
            }
            //here we can perform Add range also

            //2.Add and Remove
            List<int> nums = new List<int>()
          {
              10,20,30,40,30
          };
            nums.Remove(10);
            foreach (int x in nums)
            {
                MessageBox.Show(x.ToString());
            }
            //here we can perform remove range, remove at also

            //3.Search
            List<int> num = new List<int>()
          {
              10,20,30,40,30
          };
            bool value = num.Contains(30);
            MessageBox.Show(value.ToString());

            //4.max and min
            List<int> z = new List<int>()
          {
              10,20,30,40,30
          };
            MessageBox.Show(z.Max().ToString());
            MessageBox.Show(z.Min().ToString());

            //5.Duplicates
            List<int> w = new List<int>()
          {
              10,20,30,40,30,30,10
          };
            foreach (int g in w.Distinct())
            {
                MessageBox.Show(g.ToString());  //for unique values
            }
            int duplicates = w.Count() - w.Distinct().Count(); // for how many duplicates

            //6.Even And Odd
            List<int> f = new List<int>()
          {
              45,33,20,98,61,87
          };
            foreach (int h in f)
            {
                if (h % 2 == 0)
                {
                    MessageBox.Show(h + "Is even");
                }
                else
                {
                    MessageBox.Show(h + "Is odd"); ;
                }
            }
            //7.Sort And Reverse
            //sort-Ascending
            //sort+Reverse = Descending
            List<int> r = new List<int>()
          {
              45,33,20,98,61,87
          };
            r.Sort();
            foreach (int n in r)
            {
                MessageBox.Show(n.ToString());
            }
            r.Reverse();
            foreach (int q in r)
            {
                MessageBox.Show(q.ToString());
            }
            //8.dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                { 101, "Vasanthasenan" },
                {102, "Kanishka" }
            };
            MessageBox.Show(dic[101].ToString());
            foreach (var names in dic)
            {
                MessageBox.Show($"Id:{ names.Key}, Name:{names.Value}");
            }

            //9.hashset
            HashSet<int> values = new HashSet<int>()
            {
                22,10,10
            };
            foreach (var v in values)
            {
                MessageBox.Show(v.ToString());
            }
            //10.sortedset
            SortedSet<int> val = new SortedSet<int>()
            {
                22,10,33,1,3,2,9,4
            };
            foreach (var c in val)
            {
                MessageBox.Show(c.ToString());
            }

            //11.same as stack and queue practice
        }

    }
}
