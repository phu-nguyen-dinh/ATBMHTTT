#!/bin/bash
export ORACLE_HOME=/opt/oracle/product/23c/dbhomeFree
export ORACLE_SID=FREE
export PATH=$ORACLE_HOME/bin:$PATH

rman target / <<EOF
BACKUP DATABASE FORMAT '/opt/oracle/backups/rman/db_$(date +%Y%m%d_%H%M).bkp';
BACKUP ARCHIVELOG ALL FORMAT '/opt/oracle/backups/rman/arch_$(date +%Y%m%d_%H%M).bkp';
EXIT
EOF
