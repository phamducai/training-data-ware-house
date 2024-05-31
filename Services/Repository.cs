using Demo.Data;
using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Demo.Services
{
    public interface IRepository
    {
        Task<StrSaleDtl[]> getData();
        Task<Store[]> getStore();
        Task<int> GetSaleDtlCountAsync();
    }
    public class Repository : IRepository
    {
        private readonly DatabaseContext _context;


        public Repository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<StrSaleDtl[]> getData()
        {
            var result =_context.StrSaleDtls.ToArray();
            return result;
        }

        public async Task<Store[]> getStore()
        {
            var result = _context.Stores.ToArray();
            return result;
        }

        public async Task<int> GetSaleDtlCountAsync()
        {
            int count = 0;
            var connection = _context.Database.GetDbConnection();

            try
            {
                await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM STr_SaleDtl";
                    command.CommandType = CommandType.Text;

                    count = (int)await command.ExecuteScalarAsync();
                }
            }
            finally
            {
                await connection.CloseAsync();
            }

            return count;
        }
    }
}
