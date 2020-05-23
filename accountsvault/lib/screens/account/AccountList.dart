import 'package:accountsvault/database/dao/Account.dart';
import 'package:accountsvault/models/Account.dart';
import 'package:accountsvault/screens/account/AccountItem.dart';
import 'package:accountsvault/screens/account/Form.dart';
import 'package:accountsvault/Constants.dart';
import 'package:flutter/material.dart';

class AccountList extends StatefulWidget {
  @override
  State<StatefulWidget> createState() {
    return AccountListState();
  }
}

class AccountListState extends State<AccountList> {
  final AccountDao _dao = AccountDao();

  final TextEditingController _filter = new TextEditingController();
  String _searchText = '';

  Widget appBarTitle = new Text(
    Constants.titleAppBarAccounts,
  );

  Icon _actionIcon = new Icon(
    Icons.search,
  );

  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return new Scaffold(
      drawer: Constants.showDrawer(context),
      appBar: _buildAppBar(context),
      body: FutureBuilder<List<Account>>(
        initialData: List(),
        future: _dao.findAll(),
        builder: (contexto, snapshot) {
          switch (snapshot.connectionState) {
            case ConnectionState.none:
              break;
            case ConnectionState.waiting:
              return _buildLoading();
              break;
            case ConnectionState.active:
              break;
            case ConnectionState.done:
              final List<Account> accounts = snapshot.data
                  .where(
                      (food) => food.name.toLowerCase().contains(_searchText))
                  .toList();
              accounts.sort(
                (a, b) {
                  return a.name.toLowerCase().compareTo(b.name.toLowerCase());
                },
              );
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
      floatingActionButton: _buildFloatingActionButton(context),
    );
  }

  Widget _buildAppBar(BuildContext context) {
    return AppBar(
      title: appBarTitle,
      actions: <Widget>[
        new IconButton(
          icon: _actionIcon,
          onPressed: () {
            _pressedSearchIcon();
          },
        ),
      ],
    );
  }

  void _pressedSearchIcon() {
    setState(() {
      if (this._actionIcon.icon == Icons.search) {
        this._actionIcon = new Icon(
          Icons.close,
          color: Colors.white,
        );
        this.appBarTitle = new TextField(
          controller: _filter,
          autofocus: true,
          decoration: new InputDecoration(
            prefixIcon: new Icon(Icons.search, color: Colors.white),
            hintText: Constants.search,
            //hintStyle: new TextStyle(color: Colors.white),
          ),
          onChanged: (String text) {
            _handleSearchStart();
          },
        );
      } else {
        _handleSearchEnd();
      }
    });
  }

  Widget _buildFloatingActionButton(BuildContext context) {
    return FloatingActionButton(
      child: Icon(Icons.add),
      onPressed: () {
        Navigator.of(context).push(
          MaterialPageRoute(builder: (context) {
            return AccountForm(null);
          }),
        );
      },
    );
  }

  Widget _buildLoading() {
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
  }

  void _handleSearchStart() {
    setState(() {
      _searchText = _filter.text.toLowerCase();
    });
  }

  void _handleSearchEnd() {
    setState(() {
      this._actionIcon = new Icon(
        Icons.search,
        color: Colors.white,
      );

      this.appBarTitle = new Text(
        Constants.titleAppBarAccounts,
        style: new TextStyle(color: Colors.white),
      );

      _filter.clear();
      _searchText = '';
    });
  }
}
