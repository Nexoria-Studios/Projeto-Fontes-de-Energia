using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
[SerializeField] private GameObject menuInicial;
[SerializeField] private GameObject jogador;
[SerializeField] private GameObject menuOpcoes;
[SerializeField] private GameObject cameraOpcoes;
[SerializeField] private GameObject cameraMenu;
[SerializeField] private GameObject posProcessamentoJogo;
[SerializeField] private GameObject posProcessamentoMenu;
[SerializeField] private GameObject posProcessamentoOpcoes;

void Start()
{
    menuInicial.SetActive(true);
    menuOpcoes.SetActive(false);
    cameraMenu.SetActive(true);
    cameraOpcoes.SetActive(false);
    jogador.SetActive(false);
}

public void iniciarExploração()
{
    menuInicial.SetActive(false);
    jogador.SetActive(true);
    cameraMenu.SetActive(false);
}

public void abrirOpcoes()
{
    menuInicial.SetActive(false);
    menuOpcoes.SetActive(true);
    jogador.SetActive(false);
    cameraMenu.SetActive(false);
    cameraOpcoes.SetActive(true);
}

public void retornarAoMenu()
{
    menuInicial.SetActive(true);
    menuOpcoes.SetActive(false);
    jogador.SetActive(false);
    cameraMenu.SetActive(true);
    cameraOpcoes.SetActive(false);
}

public void mudarPosProcessamento(bool caixa)
{
    if(posProcessamentoJogo.activeSelf)
    {
    posProcessamentoJogo.SetActive(false);
    posProcessamentoMenu.SetActive(false);
    posProcessamentoOpcoes.SetActive(false);
    }
    else
    {
    posProcessamentoJogo.SetActive(true);
    posProcessamentoMenu.SetActive(true);
    posProcessamentoOpcoes.SetActive(true);
    }
}
}