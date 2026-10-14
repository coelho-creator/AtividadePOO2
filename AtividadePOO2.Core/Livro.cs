namespace AtividadePOO2.Core;

public class Livro
{
    public Livro(string categoria, string titulo, int numPaginas, string autor, string genero, int preco, string dataDeEmissao)
    {
        ValidarCategoria(categoria);
        ValidarTitulo(titulo);
        ValidarNumPaginas(numPaginas);
        ValidarAutor(autor);
        ValidarGenero(genero);
        ValidarPreco(preco);
        ValidarDataDeEmissao(dataDeEmissao);
    }
    
    public string Categoria { get; private set; }
    public string Titulo { get; private set; }
    public int NumPaginas  { get; private set; }
    public string Autor { get; private set; }
    public string Genero { get; private set; }
    public int Preco { get; private set; }
    public string DataDeEmissao { get; private set; }

    public void ValidarCategoria(string categoria)
    {
        if (string.IsNullOrWhiteSpace(categoria))
            throw new Exception("Categoria não pode estar vazio ou nulo!");
        
        Categoria = categoria;
    }

    public void ValidarTitulo(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new Exception("Titulo não pode estar vazio ou nulo!");

        Titulo = titulo;
    }

    public void ValidarNumPaginas(int numPaginas)
    {
        if (string.IsNullOrWhiteSpace(numPaginas.ToString()))
            throw new Exception("Número de páginas não pode estar vazio ou nulo!");
        
        NumPaginas = numPaginas;
    }

    public void ValidarAutor(string autor)
    {
        if (string.IsNullOrWhiteSpace(autor))
            throw new Exception("Autor não pode estar vazio ou nulo!");
        
        Autor = autor;
    }

    public void ValidarGenero(string genero)
    {
        if (string.IsNullOrWhiteSpace(genero))
            throw new Exception("Gênero não pode estar vazio ou nulo!");
        
        Genero = genero;
    }

    public void ValidarPreco(int preco)
    {
        if (string.IsNullOrWhiteSpace(preco.ToString()))
            throw new Exception("Preço não pode estar vazio ou nulo!");
        
        Preco = preco;
    }

    public void ValidarDataDeEmissao(string dataDeEmissao)
    {
        if (string.IsNullOrWhiteSpace(dataDeEmissao))
            throw new Exception("A data de emissão não pode estar vazia ou nula!");
        
        DataDeEmissao = dataDeEmissao;
    }
}