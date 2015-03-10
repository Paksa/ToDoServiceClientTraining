using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoManager.Models
{
    public class ToDoItemLocal : ToDoModel
    {
        public ToDoItemLocal(TransactionType transactionType, ToDoModel model = null) : base(model)
        {
            TransactionType = transactionType;
            this.DateTime = System.DateTime.Now;
        }
        public ToDoItemLocal(TransactionType transactionType, int id, string name, bool isCommited = false)
            : this(transactionType)
        {
            base.Id = id;
            base.Description = name;
            IsCommited = isCommited;
        }

        public ToDoItemLocal(TransactionType transactionType, ToDoModel toDoModel, bool isCommited = false)
            : this(transactionType,toDoModel)
        {
            this.IsCommited = IsCommited;
        }

        public bool IsCommited { get; private set; }

        [Key]
        public DateTime DateTime { get; private set; }

        public TransactionType TransactionType { get; set; }
    }

    public enum TransactionType
    {
        Create, Update, Delete
    }
}