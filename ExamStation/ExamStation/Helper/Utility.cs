﻿using ExamStation.Data;
using ExamStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Helper
{
    public class Utility
    {
        private readonly ExamStationDbContext _context;

        public Utility()
        {
            _context = new ExamStationDbContext();
        }

        public List<Class> GetClassList()
        {
            return _context.Class.ToList();
        }
        public List<Section> GetSectionList()
        {
            return _context.Section.ToList();
        }

        public List<Parent> GetGuardianList()
        {
            return _context.Parent.ToList();
        }

        public List<QuestionGroup> GetGroupList()
        {
            return _context.QuestionGroup.ToList();
        } 
        
        public List<Subject> GetSubjectList()
        {
            return _context.Subject.ToList();
        }
        public List<Instruction> GetInstructionList()
        {
            return _context.Instruction.ToList();
        }
    }
}
