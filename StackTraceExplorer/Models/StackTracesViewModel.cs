﻿using Caliburn.Micro;
using ICSharpCode.AvalonEdit.Document;
using System.Collections.ObjectModel;

namespace StackTraceExplorer.Models
{
    public class StackTracesViewModel : PropertyChangedBase
    {
        public StackTracesViewModel()
        {
            _stackTraces = new ObservableCollection<Stacktrace>();
        }

        private ObservableCollection<Stacktrace> _stackTraces;
        public ObservableCollection<Stacktrace> StackTraces
        {
            get
            {
                return _stackTraces;
            }
            set
            {
                _stackTraces = value;
                NotifyOfPropertyChange();
            }
        }

        public void AddStackTrace(string trace)
        {
            _stackTraces.Add(new Stacktrace(trace));
            NotifyOfPropertyChange("StackTraces");
        }
    }

    public class Stacktrace : PropertyChangedBase
    {
        public TextDocument Document { get; set; }

        public Stacktrace(string trace = null)
        {
            Document = new TextDocument { Text = trace };
        }

        private bool _wordWrap;
        public bool WordWrap
        {
            get
            {
                return _wordWrap;
            }
            set
            {
                _wordWrap = value;
                NotifyOfPropertyChange();
            }
        }
    }
}
