﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public Visualization()
        {


        }
        public Visualization(DateTime d, Content c, Member m)
        {
            this.Member = m;
            this.Content = c;
            this.VisualizationDate = d;
        }
    }
}
