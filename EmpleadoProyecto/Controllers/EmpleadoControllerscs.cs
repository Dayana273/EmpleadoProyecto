using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoProyecto.Controllers
{

    public  class EmpleadoControllerscs
    {
        readonly SQLiteAsyncConnection _Connection;
        public EmpleadoControllerscs(string DBpath)
        {
            _Connection = new SQLiteAsyncConnection(DBpath);
            _Connection.CreateTableAsync<Models.EmpleadoModels>();
        }
        
    public Task<int> SaveEmple(Models.EmpleadoModels posicion)
    {
        if (posicion.id != 0)
            return _Connection.UpdateAsync(posicion);
        else
            return _Connection.InsertAsync(posicion);
    }

    // READ one
    public Task<Models.EmpleadoModels> GetEmpleado(int pid)
    {
        return _Connection.Table<Models.EmpleadoModels>()
            .Where(i => i.id == pid)
            .FirstOrDefaultAsync();
    }
    public Task<List<Models.EmpleadoModels>> GetLisEmple()
    {
        return _Connection.Table<Models.EmpleadoModels>().ToListAsync();
    }


}






}

