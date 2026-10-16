#!/usr/bin/env python3
"""
Simple preflight script for Word-Climb.
Checks:
- data/words.csv exists
- has between 10 and 15 entries (first version requirement)
- has expected headers
Exit 0 on success, non-zero on failure.
"""
import csv
import sys
from pathlib import Path

csv_path = Path('data/words.csv')
if not csv_path.exists():
    print('FAIL: data/words.csv not found')
    sys.exit(2)

with csv_path.open(newline='') as f:
    reader = csv.DictReader(f)
    headers = reader.fieldnames or []
    expected = ['id','scrib_name','icon','sound','peak_object','stamina_cost']
    missing = [h for h in expected if h not in headers]
    if missing:
        print('FAIL: missing headers:', missing)
        sys.exit(3)
    rows = list(reader)
    count = len(rows)
    print(f'Found {count} word entries')
    if count < 10 or count > 15:
        print('FAIL: expected between 10 and 15 words for initial version')
        sys.exit(4)

print('Preflight OK')
sys.exit(0)
