﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CollectionOfSongs collection = new CollectionOfSongs();
            Tags tags = new Tags();
            tags.AddTag("pop");
            tags.AddTag("house");
            collection.AddSong("Playmen", "Fallin", 2012, tags);
            collection.ToString();
        }
    }
}
