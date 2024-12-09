using System.Security.Cryptography.X509Certificates;

namespace Person.Models
{
    public class PersonModel
    {
        public PersonModel(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

        //init: permite que o valor da propriedade seja atribuído apenas uma vez, normalmente durante a criação do objeto.
        //Guid: Define o tipo de dado da propriedade como um Globally Unique Identifier (GUID), um identificador único universal.
        public Guid Id { get; init; }
        //private set: Restringe a modificação da propriedade apenas ao código dentro da classe.
        public string Name { get; private set; }
    }
}
