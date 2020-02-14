import 'package:accountsvault/database/dao/account.dart';
import 'package:accountsvault/models/account.dart';
import 'package:accountsvault/screens/account/formulario.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:path/path.dart';
//import 'package:flutter_slidable/flutter_slidable.dart';

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
                            '$accountNameDeleted deleted',
                            style: TextStyle(color: Colors.white),
                          ),
                          backgroundColor: Colors.grey.shade900,
                          action: SnackBarAction(
                            label: 'Undo',
                            textColor: Colors.blue.shade900,
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
    return Container(
      child: ListTile(
        title: Text(_account.name.toString()),
        subtitle: Text(_account.user.toString()),
        leading: CircleAvatar(
          backgroundColor: Colors.green.shade900,
          child: Text(_account.name.length >= 2
              ? _account.name.toString().substring(0, 2)
              : _textNoNameAccounts),
        ),
        onLongPress: () {
          Clipboard.setData(
            new ClipboardData(text: _account.password),
          );
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
                onPressed: () {
                  print('Icon button tapped');
                },
              ),
            )
          ],
        ),
      ),
    );
    // actions: <Widget>[
    //     caption: 'Archive',
    //     color: Colors.blue,
    //     icon: Icons.archive,
    //     //onTap: () => _showSnackBar('Archive'),
    //   ),
    // new IconSlideAction(
    //   caption: 'Share',
    //   color: Colors.indigo,
    //   icon: Icons.share,
    //   //onTap: () => _showSnackBar('Share'),
    // ),
    // ],
    //secondaryActions: <Widget>[
    //   new IconSlideAction(
    //     caption: 'More',
    //     color: Colors.black45,
    //     icon: Icons.more_horiz,
    //     //onTap: () => _showSnackBar('More'),
    //   ),
    //   new IconSlideAction(
    //     caption: 'Delete',
    //     color: Colors.red,
    //     icon: Icons.delete,
    //     onTap: () {},
    //   ),
    // ],
    //);
  }
}
