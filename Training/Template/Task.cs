using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Template
{
    public abstract class Task
    {
        private AuditLogger _auditLogger;

        public Task()
        {
            _auditLogger = new AuditLogger();
        }

        protected Task(AuditLogger auditLogger)
        {
            _auditLogger = auditLogger;
        }


        public void Execute(string message)
        {

            DoExecute();
            _auditLogger.Log(message);
        }

        protected abstract void DoExecute();

    }
}
