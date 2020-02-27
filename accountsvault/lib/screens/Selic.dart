import 'package:accountsvault/Constants.dart';
import 'package:accountsvault/componentes/TextEditor.dart';
import 'package:intl/intl.dart';
import 'package:flutter/material.dart';

class SelicView extends StatefulWidget {
  @override
  State<StatefulWidget> createState() {
    return SelicViewState();
  }
}

class SelicViewState extends State<SelicView> {
  TextEditingController _controllerSelecValue;
  CalculaJurosSelic _selic = CalculaJurosSelic(4.25);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: Constants.showDrawer(context),
      appBar: AppBar(
        title: Text(Constants.titleAppBarSelic),
      ),
      body: Column(
        children: <Widget>[
          TextEditor(
            controller: _controllerSelecValue = TextEditingController(
              text: _selic._taxaSelic.toString(),
            ),
            inputType: TextInputType.number,
            textAlign: TextAlign.center,
            functionCompleteEditing: () {
              _selic = CalculaJurosSelic(
                  double.tryParse(_controllerSelecValue.text));
              setState(() {});
            },
          ),
          Padding(
            padding: EdgeInsets.all(32.0),
            child: _createTable(),
          ),
        ],
      ),
    );
  }

  _createTable() {
    return Table(
      border: TableBorder.all(
        color: Colors.white70,
        style: BorderStyle.solid,
        width: 0.5,
      ),
      children: [
        _createRowHeader(
          Constants.titleAppBarSelic,
        ),
        _createRowTable(
          _selic._taxaSelic.toString() + Constants.percentage,
          _selic._jurosBruto.toStringAsPrecision(4) + Constants.percentage,
        ),
        _createRowTable(
          _selic._jurosAte6Meses.toStringAsPrecision(4) + Constants.percentage,
          DateFormat(Constants.formatDate).format(
            DateTime.now(),
          ),
        ),
        _createRowTable(
          _selic._juros6Meses1Ano.toStringAsPrecision(4) + Constants.percentage,
          DateFormat(Constants.formatDate).format(
            DateTime.now().add(Duration(days: -181)),
          ),
        ),
        _createRowTable(
          _selic._juros1Ano1Ano6Meses.toStringAsPrecision(4) +
              Constants.percentage,
          DateFormat(Constants.formatDate).format(
            DateTime.now().add(Duration(days: -361)),
          ),
        ),
        _createRowTable(
          _selic._juros1Ano6Meses2Anos.toStringAsPrecision(4) +
              Constants.percentage,
          DateFormat(Constants.formatDate).format(
            DateTime.now().add(Duration(days: -721)),
          ),
        ),
      ],
    );
  }

  _createRowHeader(String data) {
    return TableRow(
      children: [
        TableCell(
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceAround,
            children: <Widget>[
              Text(data),
            ],
          ),
        ),
      ],
    );
  }

  _createRowTable(String percentage, String date) {
    return TableRow(
      children: [
        TableCell(
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceAround,
            children: <Widget>[
              //TextEditor(),
              Text(percentage),
              Text(date),
            ],
          ),
        )
      ],
    );
  }
}

class CalculaJurosSelic {
  double _taxaSelic;
  double _jurosBruto;
  double _jurosAte6Meses;
  double _juros6Meses1Ano;
  double _juros1Ano1Ano6Meses;
  double _juros1Ano6Meses2Anos;

  CalculaJurosSelic(double taxaSelic) {
    _taxaSelic = taxaSelic;
    _jurosBruto = taxaSelic / 12;
    _jurosAte6Meses =
        ((_jurosBruto / 100) - (_jurosBruto / 100) * 22.5 / 100) * 100;
    _juros6Meses1Ano =
        ((_jurosBruto / 100) - (_jurosBruto / 100) * 20.0 / 100) * 100;
    _juros1Ano1Ano6Meses =
        ((_jurosBruto / 100) - (_jurosBruto / 100) * 17.5 / 100) * 100;
    _juros1Ano6Meses2Anos =
        ((_jurosBruto / 100) - (_jurosBruto / 100) * 15.0 / 100) * 100;
  }
}
