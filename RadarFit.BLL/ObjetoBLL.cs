using Microsoft.EntityFrameworkCore;
using RadarFit.DAO;
using RadarFit.MODEL.Entities;

namespace RadarFit.BLL
{
    public class ObjetoBLL : BaseBLL
    {
        private readonly Context _db;

        public ObjetoBLL(Context db) : base(db)
        {
            _db = db;
        }

        public async Task<List<Objeto>> GetAll(int page, int limit)
        {
            try
            {
                var objetos = await (from Objeto in _db.Objeto select Objeto).ToListAsync().ConfigureAwait(false);
                return objetos;
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao trazer os dados");
            }
        }

        public async Task<Objeto> GetById(int Id)
        {
            try
            {
                var objeto = await _db.Objeto.FirstOrDefaultAsync(x => x.Id == Id).ConfigureAwait(false);
                return objeto;
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao trazer os dados");
            }
        }

        public async Task<Objeto> Create(Objeto objeto)
        {
            try
            {
                var retorno = await _db.Objeto.AddAsync(objeto).ConfigureAwait(false);
                var sucesso = await _db.SaveChangesAsync().ConfigureAwait(false);

                if (sucesso < 1)
                    throw new Exception("Houve um problema ao salvar os dados");

                return retorno.Entity;
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao salvar os dados");
            }
        }

        public async Task<Objeto> Update(Objeto objeto)
        {
            try
            {
                var objetoOriginal = await _db.Objeto.FirstOrDefaultAsync(x => x.Id == objeto.Id).ConfigureAwait(false);

                if (objetoOriginal is null)
                    throw new Exception("O item buscado não existe");

                objetoOriginal.Titulo = objeto.Titulo;
                objetoOriginal.Descricao = objeto.Descricao;

                var sucesso = await _db.SaveChangesAsync().ConfigureAwait(false);

                if (sucesso < 1)
                    throw new Exception("Houve um problema ao atualizar os dados");

                return objetoOriginal;
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao atualizar os dados");
            }
        }

        public async Task<bool> Delete(int Id)
        {
            try
            {
                var objetoOriginal = await _db.Objeto.FirstOrDefaultAsync(x => x.Id == Id).ConfigureAwait(false);

                if (objetoOriginal is null)
                    throw new Exception("O item buscado não existe");

                _db.Objeto.Remove(objetoOriginal);
                var sucesso = await _db.SaveChangesAsync().ConfigureAwait(false);

                if (sucesso < 1)
                    throw new Exception("Houve um problema ao excluir o registro");

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Houve um problema ao excluir o registro");
            }
        }
    }
}
