﻿//*********************************************************************************
//
//
//
//  NirsXLS.cs
//
//*********************************************************************************
using LinqToExcel;
using System.Linq;
using System.ComponentModel;

[ExcelSheet(Name="Анкета")]
public class NirsXLS_Columns: INotifyPropertyChanged
{

	private string _фамилия;
	private string _имя;
	private string _отчество;
	private string _датарождения;
	private string _группа;
	private string _успеваемость_средний_балл;
	private string _формаобучения;
	private string _стипендия;
	private string _скольколетзанимаетсянир;
	private string _научнаятематика_покоторойработаетстудент;
	private string _фионаучногоруководителя;
	private string _местоработынаучногоруководителя;
	private string _ученаястепеньнаучногоруководителя;
	private string _ученоезваниенаучногоруководителя;
	private string _количествопубликаций;
	private string _количествостатей;
	private string _объектыинтеллектуальнойипромышленнойсобственности_количество;
	private string _патентыиполезныемодели;
	private string _свидетельстванапрограммыдляэвм;
	private string _заявкинаизобретенияиполезныемодели;
	private string _положительныерешениянаизобретенияиполезныемодели;
	private string _программыдляэвм;
	private string _внедрениевпроизводство;
	private string _внедрениевучебныйпроцесс;
	private string _наградызанаучнуюработу;
	private string _желаетлиучитьсяваспирантуре;
	private string _желаетлиработатьвнаучно_образовательнойсфере;
	private string _планируетликафедраоставитьстудентаработатьнакафедре;
	private string _контактныетелефоны_сотовый_домашний_кафедры;
	private string _домашнийадрес;
	private string _еmail;
	private string _уровеньперспективностидляниод_1_2_3;

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void SendPropertyChanged(string propertyName)
	{
		PropertyChangedEventHandler handler = PropertyChanged;
		if (handler != null) {
			handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}


	[ExcelColumn(Name="Фамилия", Storage="_фамилия")]
	public string Фамилия
	{
		get { return _фамилия;}
		set {
			_фамилия = value; 
			SendPropertyChanged("Фамилия");
		}
	}

	[ExcelColumn(Name="Имя", Storage="_имя")]
	public string Имя
	{
		get { return _имя;}
		set {
			_имя = value; 
			SendPropertyChanged("Имя");
		}
	}

	[ExcelColumn(Name="Отчество", Storage="_отчество")]
	public string Отчество
	{
		get { return _отчество;}
		set {
			_отчество = value; 
			SendPropertyChanged("Отчество");
		}
	}

	[ExcelColumn(Name="Дата рождения", Storage="_датарождения")]
	public string Датарождения
	{
		get { return _датарождения;}
		set {
			_датарождения = value; 
			SendPropertyChanged("Датарождения");
		}
	}

	[ExcelColumn(Name="Группа", Storage="_группа")]
	public string Группа
	{
		get { return _группа;}
		set {
			_группа = value; 
			SendPropertyChanged("Группа");
		}
	}

	[ExcelColumn(Name="Успеваемость (средний балл)", Storage="_успеваемость_средний_балл")]
	public string Успеваемость_среднийбалл
	{
		get { return _успеваемость_средний_балл;}
		set {
			_успеваемость_средний_балл = value; 
			SendPropertyChanged("Успеваемость_среднийбалл");
		}
	}

	[ExcelColumn(Name="Форма обучения", Storage="_формаобучения")]
	public string Формаобучения
	{
		get { return _формаобучения;}
		set {
			_формаобучения = value; 
			SendPropertyChanged("Формаобучения");
		}
	}

	[ExcelColumn(Name="Стипендия", Storage="_стипендия")]
	public string Стипендия
	{
		get { return _стипендия;}
		set {
			_стипендия = value; 
			SendPropertyChanged("Стипендия");
		}
	}

	[ExcelColumn(Name="Сколько лет занимается НИР", Storage="_скольколетзанимаетсянир")]
	public string СкольколетзанимаетсяНИР
	{
		get { return _скольколетзанимаетсянир;}
		set {
			_скольколетзанимаетсянир = value; 
			SendPropertyChanged("СкольколетзанимаетсяНИР");
		}
	}

	[ExcelColumn(Name="Научная тематика, по которой работает студент", Storage="_научнаятематика_покоторойработаетстудент")]
	public string Научнаятематика_покоторойработаетстудент
	{
		get { return _научнаятематика_покоторойработаетстудент;}
		set {
			_научнаятематика_покоторойработаетстудент = value; 
			SendPropertyChanged("Научнаятематика_покоторойработаетстудент");
		}
	}

	[ExcelColumn(Name="ФИО научного руководителя", Storage="_фионаучногоруководителя")]
	public string ФИОнаучногоруководителя
	{
		get { return _фионаучногоруководителя;}
		set {
			_фионаучногоруководителя = value; 
			SendPropertyChanged("ФИОнаучногоруководителя");
		}
	}

	[ExcelColumn(Name="Место работы научного руководителя", Storage="_местоработынаучногоруководителя")]
	public string Местоработынаучногоруководителя
	{
		get { return _местоработынаучногоруководителя;}
		set {
			_местоработынаучногоруководителя = value; 
			SendPropertyChanged("Местоработынаучногоруководителя");
		}
	}

	[ExcelColumn(Name="Ученая степень научного руководителя", Storage="_ученаястепеньнаучногоруководителя")]
	public string Ученаястепеньнаучногоруководителя
	{
		get { return _ученаястепеньнаучногоруководителя;}
		set {
			_ученаястепеньнаучногоруководителя = value; 
			SendPropertyChanged("Ученаястепеньнаучногоруководителя");
		}
	}

	[ExcelColumn(Name="Ученое звание научного руководителя", Storage="_ученоезваниенаучногоруководителя")]
	public string Ученоезваниенаучногоруководителя
	{
		get { return _ученоезваниенаучногоруководителя;}
		set {
			_ученоезваниенаучногоруководителя = value; 
			SendPropertyChanged("Ученоезваниенаучногоруководителя");
		}
	}

	[ExcelColumn(Name="Количество публикаций", Storage="_количествопубликаций")]
	public string Количествопубликаций
	{
		get { return _количествопубликаций;}
		set {
			_количествопубликаций = value; 
			SendPropertyChanged("Количествопубликаций");
		}
	}

	[ExcelColumn(Name="Количество статей", Storage="_количествостатей")]
	public string Количествостатей
	{
		get { return _количествостатей;}
		set {
			_количествостатей = value; 
			SendPropertyChanged("Количествостатей");
		}
	}

	[ExcelColumn(Name="Объекты интеллектуальной и промышленной собственности (количество)", Storage="_объектыинтеллектуальнойипромышленнойсобственности")]
	public string Объектыинтеллектуальнойипромышленнойсобственности_количество
	{
		get { return _объектыинтеллектуальнойипромышленнойсобственности_количество;}
		set {
			_объектыинтеллектуальнойипромышленнойсобственности_количество = value; 
			SendPropertyChanged("Объектыинтеллектуальнойипромышленнойсобственности_количество");
		}
	}

	[ExcelColumn(Name="Патенты и полезные модели", Storage="_патентыиполезныемодели")]
	public string Патентыиполезныемодели
	{
		get { return _патентыиполезныемодели;}
		set {
			_патентыиполезныемодели = value; 
			SendPropertyChanged("Патентыиполезныемодели");
		}
	}

	[ExcelColumn(Name="Свидетельства на программы для ЭВМ", Storage="_свидетельстванапрограммыдляэвм")]
	public string СвидетельстванапрограммыдляЭВМ
	{
		get { return _свидетельстванапрограммыдляэвм;}
		set {
			_свидетельстванапрограммыдляэвм = value; 
			SendPropertyChanged("СвидетельстванапрограммыдляЭВМ");
		}
	}

	[ExcelColumn(Name="Заявки на изобретения и полезные модели", Storage="_заявкинаизобретенияиполезныемодели")]
	public string Заявкинаизобретенияиполезныемодели
	{
		get { return _заявкинаизобретенияиполезныемодели;}
		set {
			_заявкинаизобретенияиполезныемодели = value; 
			SendPropertyChanged("Заявкинаизобретенияиполезныемодели");
		}
	}

	[ExcelColumn(Name="Положительные решения на изобретения и полезные модели", Storage="_положительныерешениянаизобретенияиполезныемодели")]
	public string Положительныерешениянаизобретенияиполезныемодели
	{
		get { return _положительныерешениянаизобретенияиполезныемодели;}
		set {
			_положительныерешениянаизобретенияиполезныемодели = value; 
			SendPropertyChanged("Положительныерешениянаизобретенияиполезныемодели");
		}
	}

	[ExcelColumn(Name="Программы для ЭВМ", Storage="_программыдляэвм")]
	public string ПрограммыдляЭВМ
	{
		get { return _программыдляэвм;}
		set {
			_программыдляэвм = value; 
			SendPropertyChanged("ПрограммыдляЭВМ");
		}
	}

	[ExcelColumn(Name="Внедрение в производство", Storage="_внедрениевпроизводство")]
	public string Внедрениевпроизводство
	{
		get { return _внедрениевпроизводство;}
		set {
			_внедрениевпроизводство = value; 
			SendPropertyChanged("Внедрениевпроизводство");
		}
	}

	[ExcelColumn(Name="Внедрение в учебный процесс", Storage="_внедрениевучебныйпроцесс")]
	public string Внедрениевучебныйпроцесс
	{
		get { return _внедрениевучебныйпроцесс;}
		set {
			_внедрениевучебныйпроцесс = value; 
			SendPropertyChanged("Внедрениевучебныйпроцесс");
		}
	}

	[ExcelColumn(Name="Награды за научную работу", Storage="_наградызанаучнуюработу")]
	public string Наградызанаучнуюработу
	{
		get { return _наградызанаучнуюработу;}
		set {
			_наградызанаучнуюработу = value; 
			SendPropertyChanged("Наградызанаучнуюработу");
		}
	}

	[ExcelColumn(Name="Желает ли учиться в аспирантуре (да/нет)", Storage="_желаетлиучитьсяваспирантуре")]
	public string Желаетлиучитьсяваспирантуре
	{
		get { return _желаетлиучитьсяваспирантуре;}
		set {
			_желаетлиучитьсяваспирантуре = value; 
			SendPropertyChanged("Желаетлиучитьсяваспирантуре");
		}
	}

	[ExcelColumn(Name="Желает ли работать в научно-образовательной сфере (да/нет)", Storage="_желаетлиработатьвнаучно-образовательнойсфере")]
	public string Желаетлиработатьвнаучно_образовательнойсфере
	{
		get { return _желаетлиработатьвнаучно_образовательнойсфере;}
		set {
			_желаетлиработатьвнаучно_образовательнойсфере = value; 
			SendPropertyChanged("Желаетлиработатьвнаучно_образовательнойсфере");
		}
	}

	[ExcelColumn(Name="Планирует ли кафедра оставить студента работать на кафедре (да/нет)", Storage="_планируетликафедраоставитьстудентаработатьнакафедре")]
	public string Планируетликафедраоставитьстудентаработатьнакафедре
	{
		get { return _планируетликафедраоставитьстудентаработатьнакафедре;}
		set {
			_планируетликафедраоставитьстудентаработатьнакафедре = value; 
			SendPropertyChanged("Планируетликафедраоставитьстудентаработатьнакафедре");
		}
	}

	[ExcelColumn(Name="Контактные телефоны (сотовый, домашний, кафедры)", Storage="_контактныетелефоны_сотовый_домашний_кафедры")]
	public string Контактныетелефоны_сотовый_домашний_кафедры
	{
		get { return _контактныетелефоны_сотовый_домашний_кафедры;}
		set {
			_контактныетелефоны_сотовый_домашний_кафедры = value; 
			SendPropertyChanged("Контактныетелефоны_сотовый_домашний_кафедры");
		}
	}

	[ExcelColumn(Name="Домашний адрес", Storage="_домашнийадрес")]
	public string Домашнийадрес
	{
		get { return _домашнийадрес;}
		set {
			_домашнийадрес = value; 
			SendPropertyChanged("Домашнийадрес");
		}
	}

	[ExcelColumn(Name="Е-mail", Storage="_еmail")]
	public string Еmail
	{
		get { return _еmail;}
		set {
			_еmail = value; 
			SendPropertyChanged("Еmail");
		}
	}

    [ExcelColumn(Name = "Уровень перспективности  для НиОД (1,2,3)", Storage = "_уровеньперспективностидляниод_1_2_3")]
	public string УровеньперспективностидляНиОД_1_2_3
	{
		get { return _уровеньперспективностидляниод_1_2_3;}
		set {
			_уровеньперспективностидляниод_1_2_3 = value;
            SendPropertyChanged("УровеньперспективностидляНиОД_1_2_3");
		}
	}
}
