#!/bin/bash
export ORACLE_HOME=/opt/oracle/product/23c/dbhomeFree
export ORACLE_SID=FREE
export PATH=$ORACLE_HOME/bin:$PATH

expdp C##ADMIN/123456@localhost:1521/free \ 
  directory=dpump_dir \
  dumpfile=cadmin_schema_$(date +%Y%m%d).dmp \
  logfile=export_$(date +%Y%m%d).log \
  schemas=C##ADMIN
