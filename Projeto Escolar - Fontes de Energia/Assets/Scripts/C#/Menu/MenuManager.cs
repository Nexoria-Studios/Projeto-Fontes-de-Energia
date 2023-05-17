using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
[SerializeField] private GameObject menuInicial;
[SerializeField] private GameObject jogador;
[SerializeField] private GameObject menuOpcoes;
[SerializeField] private GameObject cameraOpcoes;
[SerializeField] private GameObject cameraMenu;
[SerializeField] private GameObject menuAnalisar;
[SerializeField] private GameObject cameraAnalisar;
[SerializeField] private GameObject cameraUIAnalisar;
[SerializeField] private GameObject painelAnaliseHidroeletrica;
[SerializeField] private GameObject painelAnaliseEolica;
[SerializeField] private GameObject painelAnaliseSolar;
[SerializeField] private GameObject cameraSolar;
[SerializeField] private GameObject cameraEolica;
[SerializeField] private GameObject cameraHidroeletrica;
[SerializeField] private GameObject posProcessamentoJogo;
[SerializeField] private GameObject posProcessamentoMenu;
[SerializeField] private GameObject posProcessamentoOpcoes;

private void Update()
{
    bool apertouCTRL = Input.GetButton("Fire1");

    if(apertouCTRL && jogador.activeSelf)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        retornarAoMenu();
    }
    else
    {

    }
}

void Start()
{
    menuInicial.SetActive(true);
    menuOpcoes.SetActive(false);
    cameraMenu.SetActive(true);
    menuAnalisar.SetActive(false);
    cameraUIAnalisar.SetActive(false);
    cameraOpcoes.SetActive(false);
    cameraAnalisar.SetActive(false);
    cameraEolica.SetActive(false);
    cameraSolar.SetActive(false);
    cameraHidroeletrica.SetActive(false);
    painelAnaliseEolica.SetActive(false);
    painelAnaliseHidroeletrica.SetActive(false);
    painelAnaliseSolar.SetActive(false);
    jogador.SetActive(false);
}

public void analisarHidroeletrica()
{
    cameraUIAnalisar.SetActive(false);
    cameraAnalisar.SetActive(false);
    menuAnalisar.SetActive(false);
    cameraHidroeletrica.SetActive(true);
    painelAnaliseHidroeletrica.SetActive(true);
}

public void analisarSolar()
{
    cameraUIAnalisar.SetActive(false);
    cameraAnalisar.SetActive(false);
    menuAnalisar.SetActive(false);
    cameraSolar.SetActive(true);
    painelAnaliseSolar.SetActive(true);
}

public void analisarEolica()
{
    cameraUIAnalisar.SetActive(false);
    cameraAnalisar.SetActive(false);
    menuAnalisar.SetActive(false);
    cameraEolica.SetActive(true);
    painelAnaliseEolica.SetActive(true);
}

public void analisarOutro()
{
    cameraUIAnalisar.SetActive(true);
    cameraAnalisar.SetActive(true);
    menuAnalisar.SetActive(true);
    cameraHidroeletrica.SetActive(false);
    cameraEolica.SetActive(false);
    cameraSolar.SetActive(false);
    painelAnaliseHidroeletrica.SetActive(false);
    painelAnaliseEolica.SetActive(false);
    painelAnaliseSolar.SetActive(false);
}

public void iniciarExploração()
{
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    menuInicial.SetActive(false);
    jogador.SetActive(true);
    cameraMenu.SetActive(false);
}

public void abrirAnalisar()
{
    menuInicial.SetActive(false);
    menuAnalisar.SetActive(true);
    cameraAnalisar.SetActive(true);
    cameraMenu.SetActive(false);
    cameraUIAnalisar.SetActive(true);
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
    cameraAnalisar.SetActive(false);
    cameraUIAnalisar.SetActive(false);
    menuAnalisar.SetActive(false);
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