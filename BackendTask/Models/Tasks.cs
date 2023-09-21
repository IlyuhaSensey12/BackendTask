using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendTask.Models
{

	[Table("tasks")]
	public class Tasks
	{
		[Key]
		[Column("task_id")]
		public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPriority { get; set; }

        public Tasks()
        {
        }
    }
}

