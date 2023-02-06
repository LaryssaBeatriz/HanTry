using System;

public class Usuario
{
	public String nome;
	String email;
	private String senha;
	int erroUsuario;
	int acertoUsuario;
	int totalUsuario;
		
	public Usuario(String nome, String email, String senha)
	{
		this.nome = nome;
		this.email = email;
		this.senha = senha;
	}

	public sincronizaDados() { 
	// sincroniza dados com o banco, o erro, acerto e total ; 
	}
}
