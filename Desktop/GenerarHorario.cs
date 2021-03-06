﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public class GenerarHorario
    {

        public GenerarHorario(DataGridView grid)
        {

            FillTimeDataGridView(grid);
        }        
        public void FillTimeDataGridView(DataGridView dataGridView)
        {
            int a = 0;
            int i = 9;
            while (i < 21)
            {
                string hora = "";                

                if (a == 60)
                {
                    i++;
                    a = 0;
                    hora = i + ":" + a + "0";
                    if (i < 10)
                        hora = "0" + hora;
                    dataGridView.Rows.Add(hora);
                }
                else
                {

                    hora = i + ":" + a;

                    if (i < 10 && a!=0)
                        hora = "0" + hora;
                    else if(i < 10 && a == 0)
                        hora = "0" + hora+"0";

                    dataGridView.Rows.Add(hora);
                }

                a += 15;

            }
            for(int c=0;c< dataGridView.RowCount; c++)
            {
                dataGridView.Rows[c].Cells[0].Style.BackColor = Color.CornflowerBlue;
                //dataGridView.Rows[c].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                //dataGridView.Rows[c].Cells[0].Style.SelectionBackColor = Color.Blue;
                //dataGridView.Rows[c].Cells[0].Style.SelectionForeColor = Color.White;


            }

        }
    }
}
