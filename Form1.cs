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
        private void remove_selection_circle(ref Storage stg)
        {   // Снимает выделение у всех элементов хранилища
            for (int i = 0; i < av; ++i)
            {
                if (!storag.check_emp(i))
                {   // Вызываем функцию отрисовки круга
                    paint_circle(Color.Maroon, ref storag, i);
                }
            }
        }

        private void remove_selected_circle(ref Storage stg)
        {   // Удаляет выделенные элементы из хранилища
            for (int i = 0; i < av; ++i)
            {
                if (!storag.check_emp(i))
                {
                    if (storag.objects[i].color == Color.Blue)
                    {
                        storag.deleter(i);
                    }
                }
            }
        }

        private int check_circle(ref Storage stg, int size, int x, int y)
        {   // Проверяет есть ли уже круг с такими же координатами в хранилище
            if (stg.oc(size) != 0)
            {
                for (int i = 0; i < size; ++i)
                {
                    if (!stg.check_emp(i))
                    {
                        int x1 = stg.objects[i].x - 15;
                        int x2 = stg.objects[i].x + 15;
                        int y1 = stg.objects[i].y - 15;
                        int y2 = stg.objects[i].y + 15;

                        // Если круг есть, возвращет индекс круга в хранилище
                        if ((x1 <= x && x <= x2) && (y1 <= y && y <= y2))
                            return i;
                    }
                }
            }
            return -1;
        }

        private void PanelD_MouseClick(object sender, MouseEventArgs e)
        {
            Circle circle1 = new Circle(e.X, e.Y);
            if (index == av)
            {
                storag.Dsize(ref av);
            }
            int c = check_circle(ref storag, av, circle1.x, circle1.y);
            if (c != -1)
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    if (push == 0)
                    {
                        paint_circle(Color.Maroon, ref storag, indexC);
                        push = 1;
                    }
                    paint_circle(Color.Blue, ref storag, c);
                }
                else
                {
                    remove_selection_circle(ref storag);
                    paint_circle(Color.Blue, ref storag, c);
                }
                return;
            }
            storag.add_object(index, ref circle1, av,  ref indexC);
            remove_selection_circle(ref storag);
            paint_circle(Color.Blue, ref storag, indexC);
            ++index;
            push = 0;
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            PanelD.Refresh(); // Перерисовывем панель paint_box
            for (int i = 0; i < av; ++i)
            {
                if (!storag.check_emp(i))
                {   // Меняем is_drawed на false
                    storag.objects[i].drawed = false;
                }
            }
        }

        private void ClearSB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < av; ++i)
            {
                storag.objects[i] = null;
            }
            index = 0;
        }

        private void DeleteCB_Click(object sender, EventArgs e)
        {
            remove_selected_circle(ref storag);
            PanelD.Refresh();
            if (storag.oc(av) != 0)
            {
                for (int i = 0; i < av; ++i)
                {
                    paint_circle(Color.Maroon, ref storag, i);
                }
            }
        }

        private void ShowB_Click(object sender, EventArgs e)
        {
            PanelD.Refresh();
            if (storag.oc(av) != 0)
            {
                for (int i = 0; i < av; ++i)
                {
                    if (!storag.check_emp(i))
                    {   // Меняем is_drawed на true
                        storag.objects[i].drawed = true;
                    }
                    paint_circle(Color.Maroon, ref storag, i);
                }
            }
        }
    }
}
