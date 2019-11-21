import pandas as pd
import requests
import urllib3
urllib3.disable_warnings()

#Dados URL
URL_login = 'https://granito.ime.eb.br/Granito/SisGradWeb/login.asp'
URL_Alunos = 'https://granito.ime.eb.br/Granito/SisGradWeb/AlunosConsultaResult.asp'
URL_Notas = 'https://granito.ime.eb.br/Granito/SisGradWeb/BolGrausAluno.asp'

def Login (Usuario, Senha):
    payload = { 'txtUser': '17407', 'txtSenha': '17407' }

    session = requests.session()
    r = session.post(URL_login, data=payload, verify=False)
    return session

def DF_Alunos(AnoCivil, session):
    #Pega Lista Alunos
    payload = {
        'selCurso':'0',
        'txtAnoCivil':AnoCivil,
        'txtPeriodo':'',
        'txtAnoEscolar':'',
        'selEspecialidade':'0'
    }

    r = session.post(URL_Alunos, data=payload, verify=False)

    return pd.read_html(r.text,header = 0)[0]

def DF_Notas(CodigoAluno, Ano, Periodo, session):
    #Pegar Nota
    payload = {'txtCodigo': CodigoAluno,'txtAno': Ano,'txtPeriodo': Periodo }

    r = session.post(URL_Notas, data=payload, verify=False)

    return pd.read_html(r.text)[2]


#Login
session = Login('17407','17407')

#DF Alunos
Alunos = pd.DataFrame()

for ano in list(range(2016,2020)):
    Aux = DF_Alunos(ano,session)
    Aux['Ano Consulta'] = ano
    
    Alunos = pd.concat((Alunos,Aux))

Alunos.to_csv("Alunos.csv",headr = none)

Notas = pd.DataFrame()

for index, Aluno in Alunos.iterrows():
    for Periodo in list(range(1,3)):

        Columns = ['Código', 'Disciplina', 'VE', 'VC', 'VF', 'RecEscrita','RecOral', 'Média']

        try:
            Aux = DF_Notas(Aluno['Código'], Aluno['Ano Consulta'], Periodo, session)
            Aux.columns = Columns
            
            Aux.insert (0, "Codigo Aluno", Aluno['Código'])
            Aux.insert (1, "Semestre", Periodo)
            Aux.insert (2, "Ano Consulta", Aluno['Ano Consulta'])
            
            Aux[['VE','VC','VF','RecEscrita','RecOral']] = Aux[['VE','VC','VF','RecEscrita','RecOral']]/10
            Aux[['Média']] = Aux[['Média']]/100
            
            Notas = pd.concat((Notas,Aux))
            print("Notas Adicionadas, Aluno: "+str(Aluno['Código']))

        except:
            print("Erro Aluno: " + Aluno['Nome'])

Notas.iloc[4] = Notas.iloc[4].str.replace(",","")
Notas.to_csv("Notas.csv",header = None,index = False,encoding='utf-8-sig')