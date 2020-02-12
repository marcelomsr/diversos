import 'package:accountsvault/database/dao/account.dart';
import 'package:accountsvault/models/account.dart';
import 'package:accountsvault/screens/account/formulario.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

const _titleAppBar = 'Accounts';
const _textNoNameAccounts = 'Ah';

class ListAccounts extends StatefulWidget {
  @override
  State<StatefulWidget> createState() {
    return ListAccountsState();
  }
}

class ListAccountsState extends State<ListAccounts> {
  final AccountDao _dao = AccountDao();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(_titleAppBar),
      ),
      body: FutureBuilder<List<Account>>(
        initialData: List(),
        future: _dao.findAll(),
        builder: (contexto, snapshot) {
          switch (snapshot.connectionState) {
            case ConnectionState.none:
              break;
            case ConnectionState.waiting:
              return Center(
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: <Widget>[
                    CircularProgressIndicator(),
                    Text('Loading..'),
                  ],
                ),
              );
              break;
            case ConnectionState.active:
              break;
            case ConnectionState.done:
              final List<Account> accounts = snapshot.data;
              return ListView.builder(
                itemBuilder: (context, index) {
                  final Account account = accounts[index];
                  return AccountItem(account);
                },
                itemCount: accounts.length,
              );
              break;
          }

          return Text('unknown error.');
        },
      ),
      floatingActionButton: FloatingActionButton(
        child: Icon(Icons.add),
        onPressed: () {
          Navigator.of(context).push(
            MaterialPageRoute(builder: (context) {
              return AccountForm(null);
            }),
          );
        },
      ),
    );
  }
}

class AccountItem extends StatelessWidget {
  final Account _account;

  AccountItem(this._account);

  @override
  Widget build(BuildContext context) {
    return Card(
      child: ListTile(
        //leading: Icon(Icons.monetization_on),
        title: Text(_account.name.toString()),
        subtitle: Text(_account.user.toString()),
        leading: CircleAvatar(
          backgroundColor: Colors.green.shade900,
          child: Text(_account.name.length >= 2
              ? _account.name.toString().substring(0, 2)
              : _textNoNameAccounts),
        ),
        onLongPress: () {
          Clipboard.setData(new ClipboardData(text: _account.password));
        },
        onTap: () {
          Navigator.of(context).push(
            MaterialPageRoute(builder: (context) {
              return AccountForm(_account);
            }),
          );
        },
        trailing: new Column(
          children: <Widget>[
            new Container(
              child: new IconButton(
                icon: new Icon(Icons.menu),
                onPressed: () {/* Your code */},
              ),
            )
          ],
        ),
      ),
    );
  }
}
