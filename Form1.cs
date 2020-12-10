using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int push = 0; // Нажат ли был ранее Ctrl
        static int av = 5; // Кол-во ячеек в хранилище
        Storage storag = new Storage(av); // Создаем объект хранилища
        static int index = 0; // Кол-во нарисованных кругов
        int indexC = 0; // Индекс, в какое место был помещён круг

        class Circle
        {
            public int x, y;
            public int r = 12;
            public Color color = Color.Maroon;
            public bool drawed = true;

            public Circle()
            {
                x = 0;
                y = 0;
            }

            public Circle(int x, int y)
            {
                this.x = x - r;
                this.y = y - r;
            }

            ~Circle() { }

        }

        class Storage
        {
            public Circle[] objects;

            public Storage(int count)
            {
                objects = new Circle[count];
                for (int i = 0; i < count; ++i)
                {
                    objects[i] = null;
                }
            }

            public void mesto(int count)
            {
                objects = new Circle[count];
                for (int i = 0; i < count; ++i)
                {
                    objects[i] = null;
                }
            }

            public void add_object(int ind, ref Circle object1, int count, ref int indexC)
            {
                while (objects[ind] != null)
                {
                    ind = (ind + 1) % count;
                }
                objects[ind] = object1;
                indexC = ind;
            }

            public void deleter(int ind)
            {
                objects[ind] = null;
                index--;
            }

            public bool check_emp(int index)
            {
                if (objects[index] == null)
                {
                    return true;
                }
                else return false;
            }

            public int oc(int size)
            {
                int count_oc = 0;
                for (int i = 0; i < size; ++i)
                {
                    if (!check_emp(i))
                    {
                        ++count_oc;
                    }
                }
                return count_oc;
            }

            public void Dsize(ref int size)
            {
                Storage storage1 = new Storage(size * 2);
                for (int i = 0; i < size; ++i)
                {
                    storage1.objects[i] = objects[i];
                }
                for (int i = size; i < (size*2) - 1; ++i)
                {
                    storage1.objects[i] = null;
                }
                size = size * 2;
                mesto(size);
                for (int i = 0; i < size; i++)
                {
                    objects[i] = storage1.objects[i];
                }
            }

            ~Storage() { }
        }


        private void paint_circle(Color name, ref Storage stg,int index)
        {
            Pen pen = new Pen(name, 3);
            if (!storag.check_emp(index))
            {
                if (storag.objects[index].drawed == true)
                {
                    PanelD.CreateGraphics().DrawEllipse(
                    pen,
                    stg.objects[index].x,
                    stg.objects[index].y,
                    stg.objects[index].r * 2,
                    stg.objects[index].r * 2);
                    stg.objects[index].color = name;
                }
            }
        }

        private void PanelD_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
