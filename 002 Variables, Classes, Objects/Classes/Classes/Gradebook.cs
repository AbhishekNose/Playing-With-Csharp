﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {
    class Gradebook {
        public Gradebook() {
            grades = new List<float>();
        }
        public void AddGrade(float grade) {
            grades.Add(grade);
        }
        private List<float> grades;
    }
}
