using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface Irepositorio1<T>
    {
        void Atualiza(int id, T entidade);
        void Exclui(int Id);
        void Insere(T entidade);
        List<T> Lista();
        int ProximoId();
        T retornaId(int id);
    }

    public interface Irepositorio<T>
    {
    List<T> Lista();
    T retornaId (int id);
    void Insere (T entidade);
    void Exclui (int Id);
    void Atualiza (int id, T entidade);
    int ProximoId();

    }    
}
