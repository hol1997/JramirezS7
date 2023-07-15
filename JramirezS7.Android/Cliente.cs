using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using JramirezS7.Droid;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
[assembly: Xamarin.Forms.Dependency(typeof(Cliente))]
namespace JramirezS7.Droid
{
    internal interface Cliente : datebase
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentesPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentesPath, "uisrael.db3");
            return new SQLiteAsyncConnection(path);

        }
    }
}