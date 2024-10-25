using Microsoft.Data.Sqlite; 
public class UserRepository : IRepository
 {
 public List<User> GetAll()
 {
 //devolver todos los usuarios
 }
 public User GetById(int id)
 {
 //código que devuelve un usuario del repositorio filtrando por by Id
 }
 public void Create(User usuario)
 {
 //Código para crear un usuario
 }
 public void Update(User usuario)
 {
 //Codigo para actualizar un usuario
 }
 public void Delete(User usuario)
 {
 //Codigo para eliminar un usuario
 }
 }