using ASP.NET_CORE_HTML5_WebSite.Domain.Entities;
using ASP.NET_CORE_HTML5_WebSite.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_CORE_HTML5_WebSite.Domain.Repositories.EntityFramwork
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext _context;

        public EFTextFieldsRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IQueryable<TextField> GetTextFields()
        {
            return _context.TextFields;
        }

        public TextField GetTextFieldById(Guid id)
        {
            return _context.TextFields.FirstOrDefault(i => i.Id == id);
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return _context.TextFields.FirstOrDefault(c => c.CodeWord == codeWord);
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
                _context.Entry(entity).State = EntityState.Added;
            else
                _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteTextField(Guid id)
        {
            _context.TextFields.Remove(new TextField() { Id = id });
            _context.SaveChanges();
        }
    }
}
