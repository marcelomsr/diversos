import 'package:accountsvault/database/dao/account.dart';
import 'package:accountsvault/models/account.dart';
import 'package:accountsvault/screens/Selic.dart';
import 'package:accountsvault/screens/account/formulario.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:accountsvault/Constants.dart';

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
      drawer: Drawer(
        child: ListView(
          // Important: Remove any padding from the ListView.
          padding: EdgeInsets.zero,
          children: <Widget>[
            DrawerHeader(
              child: Text('Drawer Header'),
              decoration: BoxDecoration(
                color: Colors.blue,
              ),
            ),
            ListTile(
              title: Text('Accounts'),
              onTap: () {
                // Update the state of the app
                // ...
                // Then close the drawer
                Navigator.pop(context);
              },
            ),
            ListTile(
              title: Text('Selic'),
              onTap: () {
                // Update the state of the app
                // ...
                // Then close the drawer
                //Navigator.pop(context);
                Navigator.of(context).push(
                  MaterialPageRoute(builder: (context) {
                    return SelicView();
                  }),
                );
              },
            ),
          ],
        ),
      ),
      appBar: AppBar(
        title: Text(Constants.titleAppBarAccounts),
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
                    Text(Constants.loading),
                  ],
                ),
              );
              break;
            case ConnectionState.active:
              break;
            case ConnectionState.done:
              final List<Account> accounts = snapshot.data;
              accounts.sort((a, b) {
                return a.name.toLowerCase().compareTo(b.name.toLowerCase());
              });
              return ListView.builder(
                itemBuilder: (context, index) {
                  final Account account = accounts[index];
                  return Dismissible(
                    key: Key(account.id.toString()),
                    onDismissed: (direction) {
                      setState(() {
                        _dao.delete(account.id);
                        snapshot.data.remove(account);
                      });
                      var accountNameDeleted = account.name;
                      Scaffold.of(context).showSnackBar(
                        SnackBar(
                          content: Text(
                            '$accountNameDeleted deleted.',
                            style: TextStyle(color: Colors.white),
                          ),
                          backgroundColor: Colors.grey.shade900,
                          action: SnackBarAction(
                            label: Constants.undo,
                            textColor: Constants.colorApp,
                            onPressed: () {
                              _dao.save(account);
                              setState(() {
                                accounts.add(account);
                              });
                            },
                          ),
                        ),
                      );
                    },
                    background: Container(color: Colors.grey.shade800),
                    child: AccountItem(account),
                  );
                },
                itemCount: accounts.length,
              );
              break;
          }

          return Text(Constants.unknownError);
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
    return Container(
      child: ListTile(
        title: Text(_account.name.toString()),
        subtitle: Text(_account.user.toString()),
        leading: CircleAvatar(
          backgroundColor: Colors.blue.shade500,
          child: Text(
            _account.name.length >= 2
                ? _account.name.toString().substring(0, 2)
                : Constants.textNoNameAccounts,
            style: TextStyle(color: Colors.white),
          ),
        ),
        onLongPress: () {
          Clipboard.setData(
            new ClipboardData(
              text: _account.password,
            ),
          );
          Scaffold.of(context).showSnackBar(
            SnackBar(
              content: Text(
                Constants.passwordCopied,
                style: TextStyle(color: Colors.white),
              ),
              backgroundColor: Colors.grey.shade900,
            ),
          );
        },
        onTap: () {
          Navigator.of(context).push(
            MaterialPageRoute(
              builder: (context) {
                return AccountForm(_account);
              },
            ),
          );
        },
        trailing: new Column(
          children: <Widget>[
            new Container(
              child: new IconButton(
                icon: new Icon(Icons.menu),
                onPressed: () {
                  print('Icon button pressed.');
                },
              ),
            )
          ],
        ),
      ),
    );
  }
}
