﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskStopwatch
{
    class TaskNode : TreeNode
    {
        //The duration that was originally expected to complete the task
        private TimeSpan originalEstimated;
        public TimeSpan OriginalEstimated
        {
            get { return originalEstimated; }
        }

        //The duration that is currently expected to complete the task
        private TimeSpan currentEstimated;
        public TimeSpan CurrentEstimated
        {
            get { return currentEstimated; }
            set { this.currentEstimated = value; }
        }

        //The amount of time already spent on this task
        public TimeSpan Elapsed;

        //constructor that builds the initial node
        public TaskNode(String title, TimeSpan estimatedTime)
        {
            this.Text = title;
            originalEstimated = estimatedTime;

            //the current estimated time is equal to the original until it is specifically changed.
            currentEstimated = estimatedTime;
        }

        //constructor that builds from xml saved node
        public TaskNode(String title, TimeSpan origninalEstimate, TimeSpan currentEstimate, TimeSpan elapsed)
        {
            this.Text = title;
            this.originalEstimated = origninalEstimate;
            this.currentEstimated = currentEstimate;
            this.Elapsed = elapsed;
        }

        //changes the current estimate
        public void changeEstimate(TimeSpan timeChange)
        {
            currentEstimated = currentEstimated + timeChange;
        }

        public bool isChild 
        {
            get
            {
                if (this.Nodes.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }  
        }
    }
}
