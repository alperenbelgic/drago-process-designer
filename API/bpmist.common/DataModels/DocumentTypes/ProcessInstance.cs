﻿using bpmist.common.DataModels.SubDocumentTypes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace bpmist.common.DataModels.DocumentTypes
{
    [FirestoreData]
    public class ProcessInstance : Document
    {
        [FirestoreProperty] public string OrganizationId { get; set; }

        [FirestoreProperty] public string ProcessName { get; set; }

        [FirestoreProperty] public ProcessData ProcessData { get; set; } = new ProcessData();

        [FirestoreProperty] public ProcessModel ProcessModel { get; set; }

        [FirestoreProperty] public TaskInstance[] TaskInstances { get; set; } = new TaskInstance[0];

        [FirestoreProperty] public string ProcessState { get; set; }
    }



    public class ProcessStates
    {
        public const string Running = nameof(Running);
        public const string Completed = nameof(Completed);
        public const string Cancelled = nameof(Cancelled);
    }

    public class FieldTypes
    {
        public const string Date = nameof(FieldTypes.Date);
        public const string Text = nameof(FieldTypes.Text);
    }
}
