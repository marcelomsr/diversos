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
  CalculaJurosSelic _selic = CalculaJurosSelic(Constants.rateSelic);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: Constants.showDrawer(context),
      appBar: AppBar(
        title: Text(Constants.titleAppBarSelic),
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: EdgeInsets.all(16.0),
          child: Container(
            decoration: BoxDecoration(
              borderRadius: Constants.borderRadius,
              color: Color(0xff5a348b),
              gradient: LinearGradient(
                colors: [Color(0xff8d70fe), Color(0xff2da9ef)],
                begin: Alignment.centerRight,
                end: Alignment(-1.0, -1.0),
              ), //Gradient
            ),
            child: Column(
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
                _createDataTable(),
              ],
            ),
          ),
        ),
      ),
    );
  }

  Widget _createDataTable() {
    return DataTable(
      columns: <DataColumn>[
        DataColumn(
          label: Text(''),
        ),
        DataColumn(
          label: Text(''),
        ),
      ],
      rows: <DataRow>[
        DataRow(cells: <DataCell>[
          DataCell(
            myRowDataIcon(
              Icons.arrow_forward,
              _selic._taxaSelic.toString() + Constants.percentage,
            ),
          ),
          DataCell(
            Text(
              _selic._jurosBruto.toStringAsPrecision(4) + Constants.percentage,
              style: TextStyle(
                color: Colors.white,
              ),
            ),
          ),
        ]),
        DataRow(cells: <DataCell>[
          DataCell(
            myRowDataIcon(
              Icons.arrow_forward,
              _selic._jurosAte6Meses.toStringAsPrecision(4) +
                  Constants.percentage,
            ),
          ),
          DataCell(
            Text(
              DateFormat(Constants.formatDate).format(
                DateTime.now(),
              ),
              style: TextStyle(
                color: Colors.white,
              ),
            ),
          ),
        ]),
        DataRow(cells: <DataCell>[
          DataCell(
            myRowDataIcon(
              Icons.arrow_forward,
              _selic._juros6Meses1Ano.toStringAsPrecision(4) +
                  Constants.percentage,
            ),
          ),
          DataCell(
            Text(
              DateFormat(Constants.formatDate).format(
                DateTime.now().add(Duration(days: -181)),
              ),
              style: TextStyle(
                color: Colors.white,
              ),
            ),
          ),
        ]),
        DataRow(cells: <DataCell>[
          DataCell(
            myRowDataIcon(
              Icons.arrow_forward,
              _selic._juros1Ano1Ano6Meses.toStringAsPrecision(4) +
                  Constants.percentage,
            ),
          ),
          DataCell(
            Text(
              DateFormat(Constants.formatDate).format(
                DateTime.now().add(Duration(days: -361)),
              ),
              style: TextStyle(
                color: Colors.white,
              ),
            ),
          ),
        ]),
        DataRow(cells: <DataCell>[
          DataCell(
            myRowDataIcon(
              Icons.arrow_forward,
              _selic._juros1Ano6Meses2Anos.toStringAsPrecision(4) +
                  Constants.percentage,
            ),
          ),
          DataCell(
            Text(
              DateFormat(Constants.formatDate).format(
                DateTime.now().add(Duration(days: -721)),
              ),
              style: TextStyle(
                color: Colors.white,
              ),
            ),
          ),
        ]),
        DataRow(cells: <DataCell>[
          DataCell(
            myRowDataIcon(
              null,
              '',
            ),
          ),
          DataCell(
            Text(
              '',
              style: TextStyle(
                color: Colors.white,
              ),
            ),
          ),
        ]),
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

ListTile myRowDataIcon(IconData iconVal, String rowVal) {
  return ListTile(
    leading: Icon(iconVal, color: new Color(0xffffffff)),
    title: Text(
      rowVal,
      style: TextStyle(
        color: Colors.white,
      ),
    ),
  );
}
