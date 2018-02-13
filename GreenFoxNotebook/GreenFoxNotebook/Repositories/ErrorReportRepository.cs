using GreenFoxNotebook.Entities;
using GreenFoxNotebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxNotebook.Repositories
{
    public class ErrorReportRepository
    {
        private NotebookContext notebookContext;

        public ErrorReportRepository(NotebookContext notebookContext)
        {
            this.notebookContext = notebookContext;
        }

        public List<Ticket> List()
        {
            return notebookContext.Tickets.ToList();
        }

        public void Report()
        {
            
        }

        public void Complete(int id)
        {
        }

        public List<Ticket> FilterList(string query)
        {
            return notebookContext.Tickets.Where(t => t.Manufacturer.Equals(query)).ToList();
        }
    }
}
