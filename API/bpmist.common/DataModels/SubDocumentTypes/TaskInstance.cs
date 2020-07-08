﻿using bpmist.business.common;
using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace bpmist.common.DataModels.SubDocumentTypes
{
    [FirestoreData]
    public class TaskInstance : SubDocument
    {
        [FirestoreProperty]
        public string TaskState { get; set; }

        [FirestoreProperty]
        public string AssignedUserId { get; set; }

        [FirestoreProperty]
        public string AssignedGroupId { get; set; }

        [FirestoreProperty]
        public TaskModel Task { get; set; }

        [FirestoreProperty]
        public Activity[] Activities { get; set; }

        [FirestoreProperty]
        public System.DateTime? StartedAt { get; set; }

        [FirestoreProperty]
        public System.DateTime? CompletedAt { get; set; }

    }
}