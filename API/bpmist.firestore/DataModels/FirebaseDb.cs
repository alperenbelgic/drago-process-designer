﻿using bpmist.business.common;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// I keep losing this addres:
// https://googleapis.github.io/google-cloud-dotnet/docs/Google.Cloud.Firestore/datamodel.html

namespace bpmist.firestore.DataModels
{
    public class FirestoreHelper
    {
        public T Get<T>(DocumentSnapshot documentSnapshot) where T : DocumentWithId
        {
            var obj = documentSnapshot.ConvertTo<T>();
            return obj;
        }

        public IEnumerable<T> Get<T>(QuerySnapshot querySnapshot) where T : DocumentWithId
        {
            return querySnapshot.Select(documentSnapshot => Get<T>(documentSnapshot));
        }
    }
}