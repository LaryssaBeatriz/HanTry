using System;

public class Usuario
{
	public String nome;
	String email;
	private String senha;
	int erroUsuario;
	int acertoUsuario;
	int totalUsuario;


	public Usuario() { 
	
	}

	public Usuario(String nome, String email, String senha)
	{
		this.nome = nome;
		this.email = email;
		this.senha = senha;
	}

	public int[] VerificaRepostas (Boolean[] respostas) {
		int contCerto = 0;
		int contErrado = 0;
		for (int i = 0; i < 10; i++) {
			if (respostas[i] == true)
			{
				contCerto++;
			}
			else {
				contErrado++;
			}
		}
		int[] respostasUsuario = new int[2];
		respostasUsuario[1] = contCerto;
		respostasUsuario[2] = contErrado;
		return respostasUsuario;
	}
}
